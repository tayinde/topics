//import 'jquery'
var username = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;
token = encodeURIComponent(token);

$(() =>
{
	if (username != null) {
		$('#user')
			.css('display', 'block')
			.contents()
			.html(username)
	}
	else {
		$('#signin').css('display', 'block')
	}
	$('#user').contents().on('click', (e) =>
	{
		e.preventDefault();
		window.location.href = `/Home/Profile?user=${username}&token=${token}`
	})
	window.history.pushState("object or string", "Title", window.location.href.split('?')[0]);
});

var logout = () =>
{
	localStorage.clear();
	window.location.href = '/Home/SignIn'
}