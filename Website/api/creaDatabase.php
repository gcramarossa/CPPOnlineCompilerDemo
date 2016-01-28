<?php

    if (!file_exists("conf/database.php"))
    {
        if (isset($_POST["exeWebsite"]) && isset($_POST["username"]) && isset($_POST["password"]) && isset($_POST["server"]) && isset($_POST["database"]))
        {
            $server = strip_tags(addslashes($_POST["server"]));
            $database = strip_tags(addslashes($_POST["database"]));
            $user = strip_tags(addslashes($_POST["username"]));
            $password = strip_tags(addslashes($_POST["password"]));
            $exeWebsite = strip_tags(addslashes($_POST["exeWebsite"]));
            file_put_contents("conf/database.php", "<?php    const SERVER = \"$server\";
                    const USER = \"$user\";
                    const PASSWORD = \"$password\";
                    const DATABASE = \"$database\";
                    const EXEWEBSITE = \"$exeWebsite\";
                    \$connessione = mysqli_connect(SERVER, USER, PASSWORD, DATABASE) or die(\"Impossibile connettersi al database\"); ?>");
        
            //header("Location:" . $_SERVER["PHP_SELF"]);
            $connessione = mysqli_connect($server, $user, $password, $database);
            $query = "CREATE TABLE sources (sourceID INT(11) PRIMARY KEY AUTO_INCREMENT, source VARCHAR(1000), status INT(2))";
            if(!mysqli_query($connessione, $query))
            {
                echo mysqli_error($connessione);
            }
            $query = "CREATE TABLE errors (errorID INT(11) PRIMARY KEY AUTO_INCREMENT, description VARCHAR(1000), errorType CHAR(1), EXTSourceID INT(11) NOT NULL REFERENCES sources(sourceID))";
            if(!mysqli_query($connessione, $query))
            {
                echo mysqli_error($connessione);
            }
            mysqli_close($connessione);
            header("Location:index.php");
        }        
    }

?>