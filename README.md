# SeleniumGridParralelExecutionTest

### Setting up HUB
java -jar selenium-server-standalone-3.11.0.jar -role hub

### Setting up NODE 
java -Dwebdriver.chrome.driver=C:\SeleniumDrivers\chromedriver.exe -jar selenium-server-standalone-3.11.0.jar -role node -port 5566 -hub http://localhost:4444/grid/register


