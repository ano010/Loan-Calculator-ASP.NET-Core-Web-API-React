import http from "./httpService";

const apiEndpoint = "/loanInstallmentCalculator";

export function calculateLoanInstallment(loanDetails) {
  return http.post(apiEndpoint, loanDetails);
}
