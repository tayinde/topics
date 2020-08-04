//import '../lib/jquery/dist/jquery.min'
var username = localStorage.getItem('u') || null;

$(() => {
	if (username != null) {
		$('#user')
			.css('display', 'block')
			.contents().html(username)
	}
	else {
		$('#signin').css('display', 'block')
	}
})