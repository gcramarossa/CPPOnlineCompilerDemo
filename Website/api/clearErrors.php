<?php

    include "../conf/database.php";
    session_start();
    if (isset($_SESSION["id"]))
    {
        $query = "DELETE FROM errors WHERE EXTSourceID = " . $_SESSION["id"];
        mysqli_query($connessione, $query);
    }
?>