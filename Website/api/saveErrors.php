<?php

    include "../conf/database.php";
    error_reporting(E_ALL);
    if (isset($_GET["sourceID"]) && isset($_GET["errorType"]) && isset($_GET["message"]))
    {
        
        $message = strip_tags(addslashes($_GET["message"]));
        $sourceID = (int) $_GET["sourceID"];
        $errorType = strip_tags(addslashes($_GET["errorType"]));
        if ($sourceID != 0)
        {
            $query = "INSERT INTO errors VALUES(NULL, '$message', '$errorType', $sourceID)";
            mysqli_query($connessione, $query);            
        }

    }
?>