MemComparer
===========


*The most recent executable in master is also checked in for convenience: https://github.com/Seikilos/MemComparer/raw/master/MemoryComparer/bin/Release/LISMemoryComparer.exe*

---------

Fork from base implementation at http://thinkexception.blogspot.de/2010/06/tool-to-bompare-two-windbg-dumpheap.html providing bug fixes. The original edition does not handle dumps with x64 address spaces well, so I decided to fix it.

This is a small app for all of us, which do not have access to VS2012/2013 Ultimate Edition, which is capable of comparing two different dmp files against .net memory allocations.


---------

Hints
========

Use dotMemory rather than this!

Check Survived Objects between two Snapshots (enable Collect Allocations first).
It will be an event handler most of the time anyway :/

Commands
====

* .loadby sos clr
* !dumpheap -live (or -stat, if no live data)
* Find an object of interest, dump the type info with 
* !dumpheap -type TYPE
* Pick one address and check root path
* !gcroot ADDRESS
