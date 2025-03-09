// async function getdata() {
//     return new Promise((resolve, reject) => {
//         setTimeout(() => {
//             resolve(455);

//         }, 2000);
//     })
// }
async function getData() {
    // Simulate getting data from a server


    // let x = await fetch('https://jsonplaceholder.typicode.com/todos/1')
 // let data = await x.json()
    // let data = await x.text()
    // console.log(data);

    let x = await fetch('https://jsonplaceholder.typicode.com/posts', {
        method: 'POST',
        body: JSON.stringify({
            title: 'foo',
            body: 'bar',
            userId: 1,
        }),
        headers: {
            'Content-type': 'application/json; charset=UTF-8',

        },

    })
    let data = await x.json()
   
    console.log(data);
}


async function main() {
            console.log('Loading modules');
            console.log('Doing other things');
            console.log('Load Data');
            let data = await getData()
            // data.then(v => { ??CAlbback approach
            //     console.log(data)
            //     console.log('Process Data');

            // })

            //async approach
            console.log(data)
            console.log('Process Data');

        }

main()