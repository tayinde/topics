//import 'jquery';
var user = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;

if (user == null)
{
	window.location.href = '/';
}
else
{
	$('.username').attr('value', user);
	$('.token').attr('value', token);
}

if ($('#username').text() == "" && user != null)
{
	$('#verify').submit();
}

$('#input-file').on('change', () =>
{
	var fileName = $('#input-file').val();
	var parts = fileName.split('\\');
	$('#input-file').next('.custom-file-label').html(parts[parts.length - 1]);
})