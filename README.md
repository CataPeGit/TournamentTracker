# TournamentTracker

!!! Complete details in "App.config" for the app to work, placeholder: ###--------------------###
!!! These details (such as <add key ="filePath" value="###--------------------###"/> ) are necesary to run the app


Tournament data is stored either in local files or in a sql database.

Currently data is stored in files (Tracker UI -> Program.cs -> line 22 DatabaseType.TextFile)

In order to store the data in a SQL database, you will have to set it up and change the database type as shown below.

To swap from text files to SQL change line 22 in Program.cs (Tracker UI -> Program.cs -> line 22 )
From : TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);  //(current)
To : TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
