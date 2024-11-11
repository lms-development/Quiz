import { useState } from "react";
import "./App.css";

function App() {
  const [tasks, setTasks] = useState([]);

  fetch("https://localhost:7169/api/Tasks").then((response) => {
    response.json().then((data) => {
      setTasks(data);
    });
  });

  return (
    <>
      <h1>Task List</h1>
      {tasks.map((task) => (
        <p>{task.name}</p>
      ))}
    </>
  );
}

export default App;