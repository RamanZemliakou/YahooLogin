using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YahooLoginTest
{
    public class DriverProvider
    {
        public static readonly ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

        public IWebDriver GetDriver()
        {
            if (_storedDriver.Value == null)
            {
                ChromeOptions options = new ChromeOptions();

                _storedDriver.Value = new ChromeDriver(options)
                {
                    Url = BasePageObject.url
                };
            }
            return _storedDriver.Value;
        }
        public void Quit()
        {
            _storedDriver.Value.Quit();
        }
    }
}
