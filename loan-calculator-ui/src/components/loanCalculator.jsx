import React, { useEffect, useState } from "react";
import { useForm } from "react-hook-form";
import { yupResolver } from "@hookform/resolvers/yup";
import * as yup from "yup";
import Input from "./common/input";
import Select from "./common/select";
import { calculateLoanInstallment } from "../services/loanInstallmentAmountCalculatorService";
import { getCalculationTypes } from "../services/calculationTypesService";
import { Backdrop } from "@mui/material";
import CircularProgress from "@mui/material/CircularProgress";

const schema = yup.object().shape({
  calculationType: yup.string().required().label("Calculation Type"),
  principalLoanAmount: yup
    .number()
    .min(0)
    .required()
    .label("Principal Loan Amount"),
  interestRate: yup.number().positive().required().label("Interest Rate"),
  numberOfPayments: yup
    .number()
    .positive()
    .min(1)
    .required()
    .label("Number of Payments"),
});

const LoanCalculator = () => {
  const [calculationTypes, setCalculationTypes] = useState([]);
  const [monthPayment, setMonthPayment] = useState();
  const [isLoading, setIsLoding] = useState(false);

  const {
    register,
    handleSubmit,
    formState: { errors },
    control,
    reset,
  } = useForm({
    resolver: yupResolver(schema),
  });

  useEffect(() => {
    const fetchData = async () => {
      const { data: calculationTypes } = await getCalculationTypes();
      setCalculationTypes(calculationTypes);
    };
    fetchData();
  }, []);

  const onSubmit = async (data) => {
    setIsLoding(true);
    const { data: monthPayment } = await calculateLoanInstallment(data);

    //to demonstrate the loading behavior
    setTimeout(() => {
      setMonthPayment(monthPayment);
      setIsLoding(false);
    }, 500);
  };

  const handleClear = () => {
    reset();
    setMonthPayment("");
  };

  return (
    <div>
      <div>
        <h1>Loan Calculator</h1>
      </div>
      <div>
        <form onSubmit={handleSubmit(onSubmit)}>
          <Select
            name="calculationType"
            label="Calculation Type"
            control={control}
            //   isLoading={metaData.creators ? false : true}
            options={calculationTypes}
            error={errors.calculationType?.message}
            reg={register}
          />
          <Input
            name="principalLoanAmount"
            label="Principal Loan Amount"
            reg={register}
            error={errors.principalLoanAmount?.message}
          />
          <Input
            name="interestRate"
            label="Interest Rate"
            reg={register}
            error={errors.interestRate?.message}
          />
          <Input
            name="numberOfPayments"
            label="Number of Payements"
            reg={register}
            error={errors.numberOfPayments?.message}
          />

          <button className="btn btn-primary m-2">Calculate</button>

          <button
            onClick={() => handleClear()}
            type="reset"
            className="btn btn-secondary m-2"
          >
            Reset
          </button>
        </form>

        <h5>Month Payment = $ {monthPayment}</h5>
      </div>
      <Backdrop
        sx={{ color: "#fff", zIndex: (theme) => theme.zIndex.drawer + 1 }}
        open={isLoading}
      >
        <CircularProgress color="inherit" />
      </Backdrop>
    </div>
  );
};

export default LoanCalculator;
