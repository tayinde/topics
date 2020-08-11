//import 'jquery';
var user = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;

if ($('#username').text() == "" && user != null)
{
	window.location.href = `/Home/Profile?user=${user}&token=${token}`
}
else if (user == null)
{
	window.location.href = '/';
}
else
{
	$('#u').attr('value', user);
	$('#token').attr('value', token);
}