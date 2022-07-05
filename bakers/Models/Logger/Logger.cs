namespace bakers.Models.Logger
{
    public class Logger : LogBase
    {
        private string CurrentDirectory { get; set; }
        private string FileName { get; set; }
        private string FilePath { get; set; }

    public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "bakersLog.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;
        }

        public override void Log(string Message)
        {
            using (System.IO.StreamWriter w = System.IO.File.AppendText(this.FilePath)) 
                {
                    w.WriteLine("————————");
                    w.Write("Log Entry: ");
                    w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                    w.WriteLine("...{0}", Message);
                }
        }
    }
}
