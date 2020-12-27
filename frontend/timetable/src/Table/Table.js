import React, { useEffect, useState } from "react";
const axios = require("axios");

const Table = () => {
  const [periods, setPeriods] = useState([]);

  useEffect(() => {
    axios.get("https://localhost:44382/api/TimeTable").then((response) => {
      setPeriods(response.data);
      console.log(periods);
    });
  }, []);

  let period1 = null;
  if (periods.Period1 !== undefined) {
    period1 = periods.Period1.map((data, id) => {
      return <td>{data.SubjectName}</td>;
    });
  }
  let period2 = null;
  if (periods.Period2 !== undefined) {
    period2 = periods.Period2.map((data, id) => {
      return <td>{data.SubjectName}</td>;
    });
  }
  let period3 = null;
  if (periods.Period3 !== undefined) {
    period3 = periods.Period3.map((data, id) => {
      return <td>{data.SubjectName}</td>;
    });
  }
  let period4 = null;
  if (periods.Period4 !== undefined) {
    period4 = periods.Period4.map((data, id) => {
      return <td>{data.SubjectName}</td>;
    });
  }
  let period5 = null;
  if (periods.Period5 !== undefined) {
    period5 = periods.Period5.map((data, id) => {
      return <td>{data.SubjectName}</td>;
    });
  }
  let period6 = null;
  if (periods.Period6 !== undefined) {
    period6 = periods.Period6.map((data, id) => {
      return <td>{data.SubjectName}</td>;
    });
  }
  let period7 = null;
  if (periods.Period7 !== undefined) {
    period7 = periods.Period7.map((data, id) => {
      return <td>{data.SubjectName}</td>;
    });
  }
  let period8 = null;
  if (periods.Period8 !== undefined) {
    period8 = periods.Period8.map((data, id) => {
      return <td>{data.SubjectName}</td>;
    });
  }
  return (
    <div>
      <table>
        <thead>
          <tr>
            <th>Monday</th>
            <th>Tuesday</th>
            <th>Wednesday</th>
            <th>Thursday</th>
            <th>Friday</th>
          </tr>
        </thead>
        <tbody>
          <tr>{period1}</tr>
          <tr>{period2}</tr>
          <tr>{period3}</tr>
          <tr>{period4}</tr>
          <tr>{period5}</tr>
          <tr>{period6}</tr>
          <tr>{period7}</tr>
          <tr>{period8}</tr>
        </tbody>
      </table>
    </div>
  );
};

export default Table;
