using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LISMemoryComparer
{
	public class MemoryComparerManager
	{

		public static MemoryDumpDataSet.MemoryDumpTableDataTable ConvertMemoryDump(String Name, String[] MemoryDumpLines)
		{
			MemoryDumpDataSet.MemoryDumpTableDataTable Result = new MemoryDumpDataSet.MemoryDumpTableDataTable();
			Result.TableName = Name;

			foreach (String DumpLine in MemoryDumpLines)
			{
				if (string.IsNullOrEmpty(DumpLine))
					continue;

				MemoryDumpDataSet.MemoryDumpTableRow ResultLine = Result.NewMemoryDumpTableRow();
				ConvertMemoryDumpLine(DumpLine, ResultLine);
				Result.Rows.Add(ResultLine);
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

					ResultRow.ClassName2 = ChildRow.ClassName;
					ResultRow.Count2 = ChildRow.Count;
					ResultRow.MT2 = ChildRow.MT;
					ResultRow.TotalSize2 = ChildRow.TotalSize;

					ResultRow.CountFactor = double.Parse(ResultRow.Count2) / double.Parse(ResultRow.Count1);

					Result.Rows.Add(ResultRow);
				}
			}

			return Result;
		}

		private static void ConvertMemoryDumpLine(string DumpLine, DataRow Row)
		{
			String[] Columns = SplitMemoryDumpLine(DumpLine);
			
			for (int ColIndex = 0; ColIndex < Columns.Length; ColIndex++)
			{
				String Column = Columns[ColIndex];
				Row[ColIndex] = Column;
			}
		}

		private static string[] SplitMemoryDumpLine(string DumpLine)
		{
            // Split by whitespace, skip whitespace

		    var lines = DumpLine.Trim().Split(' ');

		    var Result = new List<string>();
		
		    foreach (var line in lines)
		    {
                if (string.IsNullOrEmpty(line) == false)
                {
                    // if Result has already 4, then merge line
                    if (Result.Count == 4)
                    {
                        Result[3] += line;
                    }
                    else
                    {

                        Result.Add(line);
                    }
                }
            }

            System.Diagnostics.Debug.WriteLine(DumpLine);
            System.Diagnostics.Debug.Assert(Result.Count() == 4);

            return Result.ToArray();
        }

    }
}
