import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;


public class SelIntro {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.setProperty("webdriver.chromedriver", "C:\\Users\\deepthi.kaluvapalli\\Downloads\\chromedriver.exe");
		WebDriver driver = new ChromeDriver();
     
        driver.manage().window().maximize();
        driver.manage().deleteAllCookies();
        driver.get("https://login.yahoo.com/");
        //driver.findElement()
        
        
	}

}
