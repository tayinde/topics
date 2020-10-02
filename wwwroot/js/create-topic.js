var user = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;
import {renderTags} from './tag_renderer.js'
$('.username').attr('value', user);
$('.token').attr('value', token);

var previewToggled = false
$('#preview-button').click(() => {
	if (!previewToggled) {
		$('html, body').animate({ scrollTop: 430}, 10);
		$('#preview').show()
		$('#preview-button').html("Hide preview")
		$('#preview-content').html($('#content').val().replace(/\\n/g, '<br>'))
		$('#preview-title').html($('#title').val())
		$('#preview-author').html(user)
		$('#pfp').css('background-image', `url('${localStorage.getItem('profile_picture')}')`)
		renderTags('#preview-content')
		previewToggled = true
	} else {
		$('#preview').hide()
		$('#preview-button').html("Preview")
		previewToggled = false
	}
})