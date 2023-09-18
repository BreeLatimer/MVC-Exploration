import React, { useState, useEffect } from 'react';

const ClassRoster = () => {
    // Declare a new state variable, which we'll call "students"
    const [students, setStudents] = useState([]);

    useEffect(() => {
// GET request using fetch inside useEffect React hook
        fetch('https://localhost:44364/api/Students')
            .then(response => response.json())
            .then(data => setStudents(data));
    }, []);

    return (
        <div>
            <h1>Class Roster</h1>
            {
                students.map((item) => <h3>{item.title}</h3>)
            }
        </div>
    );
}
export default ClassRoster;