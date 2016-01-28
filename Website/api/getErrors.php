<?php

    include "../conf/database.php";
    session_start();
    if (isset($_SESSION["id"]))
    {
        $query = "SELECT * FROM errors WHERE EXTSourceID = ". $_SESSION["id"];
        $recordSet = mysqli_query($connessione, $query);
        
        while ($record = mysqli_fetch_row($recordSet))
        {
            $errorType = "Compiler";
            
            switch ($record[2])
            {
                case 'l':
                    $errorType = "Linker";
                    break;
                case 'v':
                    $errorType = "Virus";
                    break;
                case 'i':
                    $errorType = "Information";
                    
            }
            
            $errors = $record[1];
            
            if ($record[2] != 'i')
            {
                $errors = preg_replace("/^([a-zA-Z0-9\\\\\\.\\/:]+)/m", "", $record[1]);
            }
            
            echo nl2br($errorType . " message: " . $errors. "\n");
        }
    }
?>