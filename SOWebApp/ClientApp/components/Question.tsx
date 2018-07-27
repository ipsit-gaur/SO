import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';
import { QuestionState } from './TopQuestions';

interface QuestionProp {
    value: QuestionState;
}

export class Question extends React.Component<QuestionProp, any> {

    public render() {
        let val = this.props.value;

        return <div className="question row">
            <div className="count-section row col-sm-5  ">
                <div className="votes col-sm-3">
                    <div className="mini-counts"><span>{val.votes}</span></div>
                    <div className="small">votes</div>
                </div>
                <div className="col-sm-3">
                    <div className="mini-counts"><span>{val.answers}</span></div>
                    <div className="small">answers</div>
                </div>
                <div className="views col-sm-3">
                    <div className="mini-counts"><span>{val.views}</span></div>
                    <div className="small">views</div>
                </div>
            </div>
            <div className="summary col-sm-7">
                <span className="heading">{val.description}</span>
                <div className="tags">
                </div>
                <div className="started">
                    <span className="started-link">asked <span className="relativetime">{val.timeAsked}</span></span>
                    <a href="#" className="author-link"> {val.author}</a> <span className="reputation-score" dir="ltr"></span>
                </div>
            </div>
        </div>;
    }
}