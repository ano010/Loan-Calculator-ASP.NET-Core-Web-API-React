import http from "./httpService";

const apiEndpoint = "/calculationTypes";

export function getCalculationTypes(loanDetails) {
  return http.get(apiEndpoint);
}
