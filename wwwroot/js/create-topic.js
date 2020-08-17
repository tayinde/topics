user = localStorage.getItem('user') || null;
token = localStorage.getItem('token') || null;
$('.username').attr('value', user);
$('.token').attr('value', token);