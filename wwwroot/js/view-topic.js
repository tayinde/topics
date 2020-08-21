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

$('#verify').on('submit', (e) =>
{
	if (localStorage.getItem('user') == null || localStorage.getItem('token') == null)
	{
		e.preventDefault()
		window.location.href = '/Home/SignIn';
	}
})


$('.post-content').each((i, el) =>
{
	let words = $('#' + el.id).text().replace('[b]',"<b>").replace('[/b]', "</b>").trim().split(/ |\n|\t|\r/);
	words.forEach((e, i) => {
		if (e.startsWith("[img]" || "\n[img]") && e.endsWith("[/img]"))
		{
			e = e
				.replace("[img]", "<img class='padding-top-md block-img post-img' src='")
				.replace("[/img]", "") +
				"'><br>"
			words[i] = e;
		}
	});
	$('#' + el.id).html(words.join(' '))
});
