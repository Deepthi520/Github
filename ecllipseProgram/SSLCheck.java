import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class SSLCheck {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.setProperty("webdriver.chromedriver", "C:\\Users\\deepthi.kaluvapalli\\Downloads\\chromedriver.exe");
		WebDriver driver = new ChromeDriver();
     
        driver.get("https://expired.badssl.com/");
        System.out.println("driver.getTitle()");

	}

}
