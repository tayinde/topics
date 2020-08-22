//import 'jquery';
var user = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;

setInterval(() =>
{
	user = localStorage.getItem('user') || null;
	token = localStorage.getItem('token') || null
	$('.username').attr('value', user);
	$('.token').attr('value', token);
	if (localStorage.getItem('user') == null || localStorage.getItem('token') == null)
	{
		window.location.href = '/Home/Signin';
	}
	else if (submit || null == "true") $('#verify').submit();
}, 200);

$('#input-file').on('change', () =>
{
	var fileName = $('#input-file').val();
	var parts = fileName.split('\\');
	$('#input-file').next('.custom-file-label').html(parts[parts.length - 1]);
})