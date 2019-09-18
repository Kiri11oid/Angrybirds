fs = require('fs')
text = fs.readFileSync("1.txt", "utf-8")
console.log(text.length)
console.log(text)
console.log((text.charCodeAt(0)).toString(16))
//console.log(text.charCodeAt(1))
if (text.charCodeAt(0) == 0xFEFF)
	text = text.substring(1)
console.log(text)	
	
fs.writeFileSync("2.txt",text,"utf-8")

map = []
for (i = 0; i<text.length; i++)
{
	ch = text.charAt(i)
	if (map[ch]) map[ch]++; else map[ch]=1
}
for (ch in map)
	console.log(ch+ " " + map[ch]/ text.length)
