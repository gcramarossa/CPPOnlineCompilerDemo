<?php

    include "../conf/database.php";
    $query = "SELECT * FROM sources WHERE status = 1";
    
    $risultato = mysqli_query($connessione, $query);
    $record = mysqli_fetch_row($risultato);
    
    if ($record)
    {
        echo "" . $record[0] . "\n";
        echo $record[1];
        $query = "UPDATE sources SET status = 0, source = '' WHERE sourceID = $record[0]";
        $risultato = mysqli_query($connessione, $query);
    }
    
    
?>