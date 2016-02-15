using System;
using System.IO;

namespace DefectFinderTest.Helpers
{
    public static class TfsWebApi
    {
        private const string TestFilesDirectory = "JsonResponseTestData/";

        public static string GetResponse(string fileName)
        {
            string path = Path.GetFullPath(TestFilesDirectory + fileName);
            return File.ReadAllText(path);
        }
    }
}
