//import '../lib/jquery/dist/jquery.min'
$(() =>
{
	var username = localStorage.getItem('user') || null;

	if (username != null) {
		$('#user')
			.css('display', 'block')
			.contents()
			.html(username);
		$('#user')
			.contents()
			.attr('href', `/Home/Profile?user=${username}`);
	}
	else {
		$('#signin').css('display', 'block')
	}
	window.history.pushState("object or string", "Title", window.location.href.split('?')[0]);
});