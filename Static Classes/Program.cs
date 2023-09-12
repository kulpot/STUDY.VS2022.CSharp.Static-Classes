//#include <fstream>
//#include <string>
//using namespace std;
//
////ref link:https://www.youtube.com/watch?v=JCA3BWWBBb4&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=50
////C++     // defualt static
//
//ofstream outStream;
//int logNumber = 0;
//
//void initializeLogging()
//{
//    outStream.open("myLog.txt");
//}
//
//void shutdownLogging()
//{
//    outStream.close();
//}
//
//void logMessage(string message)
//{
//    outStream << (logNumber++) << ": " << message << endl;
//}
//
//void main()
//{
//    initilizeLogging();
//    logMessage("I love static data");
//    logMessage("static data exists before and after main()");
//    logMessage("When I think static, I think memory created by the compiler");
//    shutdownLogging();
//}


//C#        //explicit static


using System.IO;
using System;

static class Logger
//class Logger
{
    static StreamWriter outStream;
    static int logNumber = 0;

    static public void initializeLogging()
    {
        outStream = new StreamWriter("myLog.txt");
    }

    static public void shutdownLogging()
    {
        outStream.Close();
    }

    static public void logMessage(string message)
    {
        outStream.WriteLine((logNumber++) + ": " + message);
    }
}



class MainClass
{
    static void Main()
    {
        //Logger.meLogger = new Logger();
        //new Logger();

        Console.WriteLine("me line");
        //Console.meConsole = new Console();

        Logger.initializeLogging();
        Logger.logMessage("I love static data");
        Logger.logMessage("static data exists before and after main()");
        Logger.logMessage("When I think static, I think memory created by the compiler");
        Logger.shutdownLogging();
    }
}