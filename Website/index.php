<?php
    error_reporting(E_ALL);
    if (!file_exists("conf/database.php"))
    {
        header("Location: configuraDatabase.php");
    }
    
    include "conf/database.php";
    
?>
<!doctype html>
<html>
    <head>
        <title>CPP Online compiler</title>
        <link rel="stylesheet" href="css/general.css" />
        <script type="text/javascript" src="js/AJAX.js"></script>
        <script type="text/javascript">
        var EXEWEBSITE = "<?php echo EXEWEBSITE;?>";
        </script>
    </head>
    <body>
        <div id="container" class="arrotondato">
            <h1>CPP Online Compiler</h1>
            <p>
                <a href="#" id="compile">Compile Source</a> | 
                <a href="#" id="clear">Clear Log</a> |
                <span id="download"></span>
            </p>
            <textarea class="arrotondato" id="source">
#include <iostream>

using namespace std;

int main()
{
    cout << "Hello World" << endl;
    cin.get();
    return 0;
}
            </textarea>
            <p> Compiler output </p>
            <p class="arrotondato" id="errors"> </p>
        </div>
    <script type="text/javascript" src="js/azioni.js"></script>
    </body>
</html>