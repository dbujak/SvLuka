var remarksId = "remarks";
var remarksCountId = "remarkscount";
var remarksHeaderId = "remarksheader";

function showRemarks()
{
	if( document.getElementById ) // IE5+ & Gecko
	{
		document.getElementById(remarksId).style.visibility = "visible";
		document.getElementById(remarksId).style.display = "block";
	}
	else if( document.all ) // IE4
	{
		document.all[remarksId].style.visibility = "visible";
		document.all[remarksId].style.display = "block";
	}
	else if( document.layers ) // Netscape 4
	{
		document.layers[remarksId].visibility = "show";
		document.layers[remarksId].display = "block";
	}
}

function bringRemarksToTop()
{
	location.hash = "remarksheader";
}

function toggleRemarksVisibility()
{
	if( document.getElementById ) // IE5+ & Gecko
	{
		if( document.getElementById(remarksId).style.visibility=="visible" )
		{
			document.getElementById(remarksId).style.visibility = "hidden";
			document.getElementById(remarksId).style.display = "none";
		}
		else
		{
			document.getElementById(remarksId).style.visibility = "visible";
			document.getElementById(remarksId).style.display = "block";
		}
	}
	else if( document.all ) // IE4
	{
		if( document.all[remarksId].style.visibility=="visible" )
		{
			document.all[remarksId].style.visibility = "hidden";
			document.all[remarksId].style.display = "none";
		}
		else
		{
			document.all[remarksId].style.visibility = "visible";
			document.all[remarksId].style.display = "block";
		}
	}
	else if( document.layers ) // Netscape 4
	{
		if( document.layers[remarksId].visibility=="show" )
		{
			document.layers[remarksId].visibility = "hide";
			document.layers[remarksId].display = "none";
		}
		else
		{
			document.layers[remarksId].visibility = "show";
			document.layers[remarksId].display = "block";
		}
	}
}

function setRemarksCount(count)
{
	if( document.getElementById ) // IE5+ & Gecko
		document.getElementById(remarksCountId).innerHTML = count;
	else if( document.all ) // IE4
		document.all[elementID].innerHTML = count;
	else if( document.layers ) // Netscape 4
		document.layers[elementID].innerHTML = count;
}
