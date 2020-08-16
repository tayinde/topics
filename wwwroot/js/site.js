//import 'jquery'
var username = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;

setInterval(() =>
{
	user = localStorage.getItem('user') || null;
	token = localStorage.getItem('token') || null;
}, 200);

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