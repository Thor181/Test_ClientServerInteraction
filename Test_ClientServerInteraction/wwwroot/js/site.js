//@ts-check

const GET = 'GET';
const POST = 'POST';

registerButton('simple-get', '/home/simpleget')
registerButton('simple-get-params', '/home/SimpleGetParam?param1=hello')
registerButton('simple-get-params-obj', '/home/SimpleGetParamAsObject?body1=hello&body2=bye')
registerButton('simple-post', '/home/simplepost', { method: POST });
registerButton('simple-post-params', '/home/simplepostparam', { method: POST, body: JSON.stringify({ body: 'hello' }), headers: { 'Content-type': 'application/json' } })

function registerButton(id, url, requestInit = null) {
    const button = document.getElementById(id);
    button.addEventListener('click', async function (e) {
        await fetch(url, requestInit);
    });
}

