const simpsonsName=document.getElementById("simspson-name");
const simpsonSECONDname=document.getElementById("simspson-secondname");
const simpsonsEdad=document.getElementById("edad");
const simpsonsLast=document.getElementById("apellido");

const simname2=document.getElementById("name2");
const simsecond2=document.getElementById("secondname2");
const simedad2=document.getElementById("edad2");
const simapellido2=document.getElementById("apellido2");


const nombre3=document.getElementById("name3");
const secondName3=document.getElementById("second3");
const simapellido3=document.getElementById("apellido3");
const simedad3=document.getElementById("edad3");
const trabajo=document.getElementById("job3");

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
    const ImgSIM = simpsons.photo;
    photo.src=ImgSIM;
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




let getSimpsonData3= async()=>{
    const response=await fetch (`${simpsonsURL}/2`);
    const simpsons=await response.json();
    console.log(simpsons);
    const{firstName, secondName, lastName, age, job}=simpsons;
    nombre3.innerText=firstName;
    second3.innerText=secondName;
    simapellido3.innerText=lastName;
    simedad3.innerText=age;
    trabajo.innerText=job;
    

};

getSimpsonData3();




