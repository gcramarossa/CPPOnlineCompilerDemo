

//var timer = setInterval("updateNumbers()", 50);
document.getElementById("compile").onclick = function()
{
	AJAX.riceviDati("errors", "api/saveSource.php?source=" + encodeURIComponent(document.getElementById("source").value), "");
	//alert("OK");
}

document.getElementById("clear").onclick = function()
{
	document.getElementById("download").innerHTML = "";
	AJAX.riceviDati("errors", "api/clearErrors.php");
	document.getElementById("errors").innerHTML = "";
	//alert("OK");
}

var loop = setInterval ( function()
		{
			AJAX.riceviDati("errors", "api/getErrors.php");
		    var re = /Information message: Antivirus scanning complete\. No Viruses found\. You can download the generated file ([0-9]+)/gm; 
		    var str = document.getElementById("errors").innerHTML;
		    var subst = '<a href="' + EXEWEBSITE +'$1.exe">Download Generated File</a>'; 
		     
		    var result = str.replace(re, subst).split("\n");
		    
		    if(result.length > 3)
	    	{
		    	document.getElementById("download").innerHTML = result[result.length - 2];
	    	}
		    else
	    	{
		    	document.getElementById("download").innerHTML = "";
	    	}
		    
		}, 500);