import "./App.css";
import "bootstrap/dist/css/bootstrap.css";
import {
  BrowserRouter,
  Routes,
  Route,
  Link,
  useNavigate,
} from "react-router-dom";
import React from "react";
import RegistrationPage from "./main/registrationPage";
import Login from "./main/login";
import PatientHomepage from "./main/patient/patientHomepage";

function App() {
  const navigate = useNavigate();

  let onClickRegister = (event) => {
    event.preventDefault();
    navigate("/registerPatient");
  };

  return (
    <React.Fragment>
      <div className="App">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
          <div className="container-fluid">
            <button>Homepage</button>
          </div>
          <div className="container-fluid">
            <button onClick={onClickRegister}>Register</button>
          </div>
          <div className="container-fluid">
            <button onClick={(event) => navigate("/login")}>Login</button>
          </div>
        </nav>
        <Routes>
          <Route path="/registerPatient" element={<RegistrationPage />} />
          <Route path="/login" element={<Login />} />
          <Route path="/patientHomepage" element={<PatientHomepage />} />
        </Routes>
      </div>
    </React.Fragment>
  );
}

export default App;
