//import 'jquery'
var username = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;
token = encodeURIComponent(token);

$(() =>
{
	if (username != null) {
		$('#profile')
			.css('display', 'block')
			.contents()
			.html(username)
	}
	else {
		$('#signin').css('display', 'block')
	}
	$('#profile').contents().on('click', (e) =>
	{
		e.preventDefault();
		$('.username').attr('value', username);
		$('.token').attr('value', token);
		$('#verifyNav').submit();
	})
});

var logout = () =>
{
	localStorage.clear();
	window.location.href = '/Home/SignIn'
}