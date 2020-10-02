//import 'jquery';
import { renderTags } from './tag_renderer.js';
var user = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;

setInterval(() =>
{
	user = localStorage.getItem('user') || null;
	token = localStorage.getItem('token') || null
	$('.username').attr('value', user);
	$('.token').attr('value', token);
}, 200);

$('#verify').on('submit', (e) =>
{
	if (localStorage.getItem('user') == null || localStorage.getItem('token') == null)
	{
		e.preventDefault()
		window.location.href = '/Home/SignIn';
	}
})

renderTags('.post-content');
var previewToggled = false
$('#preview-button').click(() => {
	if (!previewToggled) {
		$('html, body').animate({ scrollTop: $('body').height()}, 10);
		$('#preview-area').show()
		$('#preview-button').html("Hide preview")
		$('#preview-content').html($('#content').val().replace(/\\n/g, '<br>'))
		$('#preview-author').html(user + ' ' + $('#preview-author').val())
		$('#pfp').css('background-image', `url('${localStorage.getItem('profile_picture')}')`)
		renderTags('#preview-content')
		previewToggled = true
	} else {
		$('#preview-area').hide()
		$('#preview-button').html("Preview")
		previewToggled = false
	}
})
