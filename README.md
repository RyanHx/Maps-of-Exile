# Welcome to Maps of Exile!

**Maps of Exile** is a desktop application used for buying maps in bulk in Path of Exile. You select the maps you want and it'll aggregate any results by account to save time on trading.

## Getting started

Download the application [here]

Simply open up the application via the MapsOfExile.exe and tick any maps you'd like from the list to the left of the window. Then select your league via the dropdown box in the bottom left, and hit Search!

The results will then show up in the panel on the right hand side of the window. To generate a whisper message simply click on the account name in the results panel, or select the account manually via the **Account** dropdown box. 

The results are formatted as follows:

Account Name

Checkbox (include/exclude map) | Map name | Slider (to select amount) | Selected amount / Stock | Price per map

### Menu
In the top right of the window you'll see a menu which includes the following items:

#### Number of results
This will tell the program how many results to retrieve **per map selected**. Meaning if this selection is on 10 and you select two maps from the map list you'll get 20 total results. This is to prevent sending too many requests to the trade API and having yourself placed on cooldown. During production of the app I did hit the search request limit but it was after several hundred requests whilst testing.
#### Enable logging
This will have the program log it's actions in a text file located at **ExeBaseDirectory/Logs/Logs.txt**. It will also be useful if you come across any bugs since the output will point me in the right direction to create fixes!

## You're all set!
That's pretty much it to get things up and running! Here's some info to get hold of me if you have any questions:
* Path of Exile: RyanHx
* Reddit: u/RyanHx
* Discord: Ryan#3986

### Help! The program's not working!
There might be a few things happening so try the following before submitting a bug report:
* Download the latest .NET [here](https://dotnet.microsoft.com/download) (the **framework runtime** on the right hand side)
* Run the program as admin - depending on the drive you have the application on it may need admin privileges in order to create the default log file and copy text to the clipboard.
* Add a rule in your firewall - a firewall is the most likely cause of any connection errors.
* Check the API is up - there should be notifications on any failed HTTP requests. If the API is up and the problem's still happening, let me know how to reproduce the error and I'll work on a fix ASAP.

If all else fails you can submit a bug report here [ADD LINK]
