import React from "react";

const Input = ({ name, label, reg, error, ...rest }) => {
  return (
    <div className="form-group">
      <label htmlFor={name}>{label}</label>
      <input
        {...rest}
        {...reg(name)}
        name={name}
        id={name}
        className={`form-control ${error ? "is-invalid" : ""}`}
      />
      <div className="invalid-feedback">{error}</div>
    </div>
  );
};

export default Input;
