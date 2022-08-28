import React from "react";
import { ToastContainer } from "react-toastify";
import LoanCalculator from "./components/loanCalculator";
import "./App.css";
import "react-toastify/dist/ReactToastify.css";

function App() {
  return (
    <React.Fragment>
      <ToastContainer />
      <main className="loan-details-form">
        <LoanCalculator />
      </main>
    </React.Fragment>
  );
}

export default App;
