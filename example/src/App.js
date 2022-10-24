import { useState } from "react";

function App() {
  const [users, setUsers] = useState([]);

  const getUsers = async () => {
    const response = await fetch("api/users", {
      method: "get",
    });

    const reponseJson =  await response.json();

    setUsers(reponseJson);
  };

  return (
    <div className="App">
      <button onClick={getUsers}>GET USERS</button>
      <ul>
        {users?.map((user) => {
          <li key={user}>{user}</li>;
        })}
      </ul>
    </div>
  );
}

export default App;
