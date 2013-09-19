
function noTimeClicked()
{
	if ( Form1.chkNoTime.checked == true )
	{
		Form1.cboHour.style.visibility = "hidden";
		Form1.cboMin.style.visibility = "hidden";
		Form1.cboAM.style.visibility = "hidden";
	}
	else
	{
		Form1.cboHour.style.visibility = "visible";
		Form1.cboMin.style.visibility = "visible";
		Form1.cboAM.style.visibility = "visible";
	}
}