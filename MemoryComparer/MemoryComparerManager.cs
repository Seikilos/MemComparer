using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace LISMemoryComparer
{
    public class MemoryComparerManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="MemoryDumpLines"></param>
        /// <param name="matchFilter">If returns true, only this entry will be used</param>
        /// <returns></returns>
        public static MemoryDumpDataSet.MemoryDumpTableDataTable ConvertMemoryDump(String Name, String[] MemoryDumpLines, Func<MemoryDumpDataSet.MemoryDumpTableRow, bool> matchFilter = null)
        {
            var errors = new List<string>();
            MemoryDumpDataSet.MemoryDumpTableDataTable Result = new MemoryDumpDataSet.MemoryDumpTableDataTable();
            Result.TableName = Name;

            foreach (String DumpLine in MemoryDumpLines)
            {
                if (string.IsNullOrEmpty(DumpLine))
                {
                    continue;

                }

                MemoryDumpDataSet.MemoryDumpTableRow ResultLine = Result.NewMemoryDumpTableRow();
                try
                {
                    ConvertMemoryDumpLine(DumpLine, ResultLine);
                }
                catch (Exception e)
                { 
                    errors.Add(string.Format("Parsing line '{0}' failed with '{1}'", DumpLine, e.Message));
                    continue;
                }
               
                // Use matchFilter
                if (matchFilter != null && matchFilter(ResultLine) == false)
                {
                    continue;
                }


                Result.Rows.Add(ResultLine);
            }

            if (errors.Count > 0)
            {
                var finalErrors = errors;
                if (errors.Count > 100)
                {
                    MessageBox.Show("Too many errors generated, not all are shown");
                    finalErrors = errors.Take(10).ToList();
                }
                // this violates some patterns
                MessageBox.Show(string.Format("Errors in lines:{0}{1}", Environment.NewLine, string.Join(Environment.NewLine, finalErrors)));
            }
            return Result;
        }

        public static MemoryDumpDataSet.JoinedMemoryDumpTableDataTable Join(MemoryDumpDataSet.MemoryDumpTableDataTable First, MemoryDumpDataSet.MemoryDumpTableDataTable Second)
        {
            DataSet JoinedSet = new DataSet();
            JoinedSet.Tables.Add(First);
            JoinedSet.Tables.Add(Second);
            JoinedSet.Relations.Add(new DataRelation("a", First.ClassNameColumn, Second.ClassNameColumn, false));

            MemoryDumpDataSet.JoinedMemoryDumpTableDataTable Result = new MemoryDumpDataSet.JoinedMemoryDumpTableDataTable();
            foreach (MemoryDumpDataSet.MemoryDumpTableRow Row in JoinedSet.Tables[First.TableName].Rows)
            {
                foreach (MemoryDumpDataSet.MemoryDumpTableRow ChildRow in Row.GetChildRows("a"))
                {
                    MemoryDumpDataSet.JoinedMemoryDumpTableRow ResultRow = Result.NewJoinedMemoryDumpTableRow();
                    ResultRow.ClassName1 = Row.ClassName;
                    ResultRow.Count1 = Row.Count;
                    ResultRow.MT1 = Row.MT;
                    ResultRow.TotalSize1 = Row.TotalSize;
                    ResultRow.DeltaCount = ChildRow.Count - Row.Count;
                    ResultRow.ClassName2 = ChildRow.ClassName;
                    ResultRow.Count2 = ChildRow.Count;
                    ResultRow.MT2 = ChildRow.MT;
                    ResultRow.TotalSize2 = ChildRow.TotalSize;

                    ResultRow.CountFactor = (double)(ResultRow.Count2) / ResultRow.Count1;

                    Result.Rows.Add(ResultRow);
                }
            }

            return Result;
        }

        private static void ConvertMemoryDumpLine(string DumpLine, DataRow Row)
        {
            String[] Columns = SplitMemoryDumpLine(DumpLine);

            if (Columns == null)
            {
                throw new Exception("Columns could not be parsed");
            }

            for (int ColIndex = 0; ColIndex < Columns.Length; ColIndex++)
            {
                String Column = Columns[ColIndex];
                Row[ColIndex] = Column;
            }
        }

        private static string[] SplitMemoryDumpLine(string DumpLine)
        {
            // Split by whitespace, skip whitespace

            var parts = DumpLine.Trim().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 4)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to split line '{0}' into four or more parts. Skipping", DumpLine));
                return null;
            }

            if (parts.Length == 4)
            {
                return parts;
            }

            // There are more than 4 entries, merge all entries from 3 with whitespace back
            var sb = new StringBuilder(parts[3]);
            foreach (var p in parts.Skip(4))
            {
                sb.Append(" "+p);
            }

           return new[] { parts[0], parts[1], parts[2], sb.ToString() };

            
        }

    }
}
