var formatting = {
	"\\[b]": "<b>",
	"\\[/b]": "</b>",
	"\\[u]": "<u>",
	"\\[/u]": "</u>",
	"\\[h1]": "<h1>",
	"\\[/h1]": "</h1>",
	"\\[h2]": "<h2>",
	"\\[/h2]": "</h2>",
	"\\[h3]": "<h3>",
	"\\[/h3]": "</h3>",
	"\\[h4]": "<h4>",
	"\\[/h4]": "</h4>",
	"\\[h5]": "<h5>",
	"\\[/h5]": "</h5>",
	"\\[h6]": "<h6>",
	"\\[/h6]": "</h6>",
	"\\[i]": "<i>",
	"\\[/i]": "</i>",
	"\\[li]": "<li class='margin-left-xl'>",
	"\\[/li]": "</li>",
	"\\[br]": "<br>"
}
export var renderTags = function (element)
{
	$(element).each((i, el) =>
	{
		let words = $('#' + el.id).text();
		words = words.replace('[/link]', '[/link] ')
		Object.keys(formatting).forEach(f => {
			words = words.replace(new RegExp(`(${f})`, 'g'), formatting[f]);
		});
		words = words.trim().split(/ |\n|\t|\r/);
		words.forEach((e, i) => {
			if (e.includes("[img]") && e.includes("[/img]"))
			{
				e = e
					.replace("[img]", "<img class='padding-top-md block-img post-img' src='")
					.replace("[/img]", "") +
					"'><br>"
				words[i] = e;
			} else if (e.includes("[link]") && e.includes("[/link]"))
			{
				console.log(e);
				e = e
					.replace("[link]", "<a href='")
					.replace("[/link]", "'>")
				e = e + `${e.substr(e.indexOf("<a href='") + 9, e.indexOf("'", e.indexOf("'") + 1) - 9)}</a>`
				console.log(e);
				words[i] = e;
			}
		});
		$('#' + el.id).html(words.join(' '))
	});
}