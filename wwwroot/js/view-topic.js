//import 'jquery';
var user = localStorage.getItem('user') || null;
var token = localStorage.getItem('token') || null;

setInterval(() =>
{
	user = localStorage.getItem('user') || null;
	token = localStorage.getItem('token') || null
	$('.username').attr('value', user);
	$('.token').attr('value', token);
}, 200);