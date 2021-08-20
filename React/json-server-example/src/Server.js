const jsonServer = require('json-server')
const server = jsonServer.create()
const path = require('path')
const router = jsonServer.router(path.join(__dirname, 'db.json'))


server.use(router)

server.get('/', (req, res) => {
	res.send('I am alive')
});

server.listen(3001, (err) => {
	if (err)
		console.log('Something went wrong \n', err);
	else
		console.log('JSON Server is running');
});
