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

$('#input-file').on('change', () =>
{
	var fileName = $('#input-file').val();
	var parts = fileName.split('\\');
	$('#input-file').next('.custom-file-label').html(parts[parts.length - 1]);
})