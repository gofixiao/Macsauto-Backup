namespace Macsauto.Infrastructure.Helper.MySql
{
    using System.Diagnostics;

    public class MySqlDumper
    {
        private Process _mySqlDump;

        public MySqlDumper(string host, string username, string password, string database, string savepath)
        {
            string arguments = string.Format(
                                    @"-u {0} -p {1} -h{2} {3} -r \{4}",
                                    username,
                                    password,
                                    host,
                                    database,
                                    savepath
                                );

            _mySqlDump = new Process
                {
                    StartInfo =
                        {
                            FileName = @"mysqldump.exe", 
                            UseShellExecute = false, 
                            Arguments = arguments,
                            RedirectStandardInput = false,
                            RedirectStandardOutput = false,
                            CreateNoWindow = true
                        }
                };
        }

        public void Dump()
        {
            _mySqlDump.Start();
            _mySqlDump.WaitForExit();
            _mySqlDump.Close();
            _mySqlDump.Dispose();
        }
    }
}