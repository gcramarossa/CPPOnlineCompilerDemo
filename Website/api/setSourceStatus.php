<?php

    include "../conf/database.php";
    if (isset($_GET["sourceID"]) && isset($_GET["status"]))
    {
        $sourceID = (int) $_GET["sourceID"];
        $status = (int) $_GET["status"];
        $query = "UPDATE sources SET status = $status WHERE sourceID = $sourceID";
        
        mysqli_query($connessione, $query);
    }
    
?>