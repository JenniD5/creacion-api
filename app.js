const simpsonsName=document.getElementById("simspson-name");
const simpsonSECONDname=document.getElementById("simspson-secondname");
const simpsonsEdad=document.getElementById("edad");
const simpsonsLast=document.getElementById("apellido");

const simname2=document.getElementById("name2");
const simsecond2=document.getElementById("secondname2");
const simedad2=document.getElementById("edad2");
const simapellido2=document.getElementById("apellido2");




const simpsonsURL='https://localhost:5001/simpsons/Character';

let getSimpsonData=async()=>{
    const response=await fetch(`${simpsonsURL}/1`);
    const simpsons=await response.json();
    console.log(simpsons);
    const{firstName,secondName,age,lastName}=simpsons;
    simpsonsName.innerText=firstName;
    simpsonSECONDname.innerText=secondName;
    simpsonsEdad.innerText=age;
    simpsonsLast.innerText=lastName;
};

getSimpsonData();



let getSimpsonData2= async()=>{
    const response=await fetch (`${simpsonsURL}/0`);
    const simpsons=await response.json();
    console.log(simpsons);
    const{firstName,secondName,age,lastName}=simpsons;


    simname2.innerText=firstName;
    simsecond2.innerText=secondName;
    simedad2.innerText=age;
    simapellido2.innerText=lastName;
};

getSimpsonData2();