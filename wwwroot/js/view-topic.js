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
