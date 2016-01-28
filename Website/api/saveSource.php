<?php

    include "../conf/database.php";
    session_start();
    if (isset($_GET["source"]))
    {
        $source = addslashes($_GET["source"]);

        $record = false;
        if (isset($_SESSION['id']))
        {
            $query = "SELECT * FROM sources WHERE sourceID = " . $_SESSION["id"]. "";  
            $record = mysqli_query($connessione, $query);
        }

        if ($record)
        {
            $query = "UPDATE sources SET source = '$source', status = 1 WHERE sourceID = ". $_SESSION["id"];
        }
        else
        {
            $query = "INSERT INTO sources VALUES(NULL, '$source', 1)";
        }      

        $risultato = mysqli_query($connessione, $query);
        
        if (!$record)
        {
            $_SESSION["id"] = mysqli_insert_id($connessione);
        }
    }
    else
    {
        echo "No";
    }

    
    
?>