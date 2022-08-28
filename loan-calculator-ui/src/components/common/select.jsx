import React, { Component } from "react";

const Select = ({ name, label, reg, options, error, ...rest }) => {
  return (
    <div className="form-group">
      <label htmlFor={name}>{label}</label>
      <select
        name={name}
        id={name}
        {...reg(name)}
        {...rest}
        className={`form-control ${error ? "is-invalid" : ""}`}
      >
        <option value="">Please Choose...</option>
        {options &&
          options.map((option) => (
            <option key={option.id} value={option.id}>
              {option.name || option.value || option.category || option.status}
            </option>
          ))}
      </select>
      <div className="invalid-feedback">{error}</div>
    </div>
  );
};

export default Select;
