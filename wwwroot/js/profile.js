//import 'jquery';
var user = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;

setInterval(() =>
{
	user = localStorage.getItem('user') || null;
	token = localStorage.getItem('token') || null
	$('.username').attr('value', user);
	$('.token').attr('value', token);
	if (user == null || token == null)
	{
		window.location.href = '/';
	}
	if (submit || null == "true") $('#verify').submit();
}, 200);

$('#input-file').on('change', () =>
{
	var fileName = $('#input-file').val();
	var parts = fileName.split('\\');
	$('#input-file').next('.custom-file-label').html(parts[parts.length - 1]);
})