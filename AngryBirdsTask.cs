My1Node = new Object()
My1Node.str = 'А'
My1Node.value = 1

My2Node = {
	str : 'л',
	value : 1 
}

My3Node = {
	str : 'Ал',
	value :My2Node + My1Node  ,
	left : MyFirstNode,
	right : MySecondNode 
}

let text = fs.readFileSync('1.txt','utf-8')
console.log(text)
map = [text]
for (i = 0; i<text.length; i++)
{
    ch = text.charCodeAt(i)
    if (map[ch]) map[ch]++; else
    map[ch]=1
}



console.log(My3Node)











/*
let fs = require('fs')
let text = fs.readFileSync('1.txt','utf-8')
console.log(text)
console.log(text.charCodeAt(0).toString(16))
console.log(text.charCodeAt(1).toString(16))
console.log(text.charAt(1))
//console.log(text.charCodeAt(1))
//BOM, byte Order Mark -Check
if (text.charCodeAt(0) == 0xFEFF)
   text = text.substring(1)
console.log(text)
//console.log(text.charAt(1))
fs.writeFileSync('2.txt', text, 'utf-8')
map = []
for (i = 0; i<text.length; i++)
{
    ch = text.charCodeAt(i)
    if (map[ch]) map[ch]++; else
    map[ch]=1
}
for (ch in map)
    console.log(ch+ " " +map[ch]/text.length)
	*/
	
