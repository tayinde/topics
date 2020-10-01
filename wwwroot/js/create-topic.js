var user = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;
import {renderTags} from './tag_renderer.js'
$('.username').attr('value', user);
$('.token').attr('value', token);

$('#preview-button').click(() => {
	$('#preview').show()
	$('#preview-content').html($('#content').val())
	$('#preview-title').html($('#title').val())
	$('#preview-author').html(user)
	$('#pfp').css('background-image', `url('${localStorage.getItem('profile_picture')}')`)
	renderTags('#preview-content')
})