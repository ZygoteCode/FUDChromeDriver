namespace FUDChromeDriver.Example
{
    public class Program
    {
        public static void Main()
        {
            UndetectedChromeDriver driver = UndetectedChromeDriver.Create(driverExecutablePath: "C:\\Users\\Z\\Desktop\\FUDChromeDriver\\FUDChromeDriver\\bin\\x64\\Release\\net9.0\\chromedriver.exe", browserExecutablePath: "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            driver.GoToUrl("https://bot.sannysoft.com");
        }
    }
}