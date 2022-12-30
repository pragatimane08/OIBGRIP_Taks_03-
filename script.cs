let celcious = document.getElementById('celcious');
let fahrenheit = document.getElementById('fahrenheit');

celcious.oninput = () => {
    let output =(parseFloat(celcious.value)*9/5 + 32);
    fahrenheit.value = parseFloat(output.toFixed(2));
};

 fahrenheit.oninput = ()=>{
    let output =((parseFloat(celcious.value)-32)*5)/9;
    fahrenheit.value = parseFloat(output.toFixed(2));
};
